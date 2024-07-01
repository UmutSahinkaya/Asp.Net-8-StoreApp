﻿using StoreApp.Data.Concrete;
using StoreApp.Web.TagHelpers;
using System.Text.Json.Serialization;

namespace StoreApp.Web.Models;

public class SessionCart:Cart
{
    public static Cart GetCart(IServiceProvider services)
    {
        ISession? session = services.GetRequiredService<IHttpContextAccessor>().HttpContext?.Session;
        SessionCart cart = session?.GetJson<SessionCart>("cart") ?? new SessionCart();
        cart.Session = session;
        return cart;
    }
    [JsonIgnore]
    public ISession? Session { get; set; }
    public override void AddItem(Product product, int quantity)
    {
        base.AddItem(product, quantity);
        Session?.SetJson("cart", this);
    }
    public override void RemoveItem(Product product)
    {
        base.RemoveItem(product);
        Session?.SetJson("cart", this);
    }

    public override void Clear()
    {
        base.Clear();
        Session?.Remove("cart");
    }
}