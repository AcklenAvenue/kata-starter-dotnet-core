"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
class NoDiscountStrategy {
    execute(item) {
        return 0;
    }
    shouldHandle(customer, date, item) {
        return false;
    }
}
exports.NoDiscountStrategy = NoDiscountStrategy;
