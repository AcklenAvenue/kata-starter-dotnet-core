import {IDiscountStrategy} from "./IDiscountStrategy";
import {CartItem} from "./cartItem";
import {Customer} from "./customer";

export class AllPantsDiscountStrategy implements IDiscountStrategy {
    execute(item: CartItem): number {
        return item.price - 2;
    }

    shouldHandle(customer: Customer, date: Date, item: CartItem): boolean {
        return item.name === "pair of pants";
    }
}