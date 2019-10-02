"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
class MondayShirtDiscountStrategy {
    execute(item) {
        return item.price * .8;
    }
    shouldHandle(customer, date, item) {
        if (item.name !== "shirt")
            return false;
        const isMonday = date.getDay() === 1;
        return isMonday;
    }
}
exports.MondayShirtDiscountStrategy = MondayShirtDiscountStrategy;
