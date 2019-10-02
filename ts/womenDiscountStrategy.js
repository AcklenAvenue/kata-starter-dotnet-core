"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
class WomenDiscountStrategy {
    execute(item) {
        return item.price * .9;
    }
    shouldHandle(customer, date, item) {
        return customer.gender === "female";
    }
}
exports.WomenDiscountStrategy = WomenDiscountStrategy;
