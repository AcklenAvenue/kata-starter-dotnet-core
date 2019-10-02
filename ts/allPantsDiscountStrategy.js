"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
class AllPantsDiscountStrategy {
    execute(item) {
        return item.price - 2;
    }
    shouldHandle(customer, date, item) {
        return item.name === "pair of pants";
    }
}
exports.AllPantsDiscountStrategy = AllPantsDiscountStrategy;
