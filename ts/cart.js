"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
const cartItem_1 = require("./cartItem");
class Cart {
    constructor(cartCalculator) {
        this._cartCalculator = cartCalculator;
        this._items = [];
    }
    pushItem(name, price) {
        this._items.push(new cartItem_1.CartItem(name, price));
    }
    calculate(customer, date) {
        return this._cartCalculator.calculate(customer, date, this._items);
    }
}
exports.Cart = Cart;
