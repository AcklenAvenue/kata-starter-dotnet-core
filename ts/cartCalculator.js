"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
class CartCalculator {
    constructor(strategies) {
        this._strategies = strategies;
    }
    calculate(customer, date, items) {
        return items
            .map(i => this.getDiscountedPrice(i, customer, date))
            .reduce((p, c) => c + p);
    }
    getDiscountedPrice(item, customer, date) {
        const priceOptions = this._strategies
            .filter(s => s.shouldHandle(customer, date, item))
            .map(s => s.execute(item));
        if (priceOptions.length === 0)
            return item.price;
        return Math.max(...priceOptions);
    }
}
exports.CartCalculator = CartCalculator;
