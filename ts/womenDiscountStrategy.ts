import {IDiscountStrategy} from "./IDiscountStrategy";
import {Customer} from "./customer";
import {CartItem} from "./cartItem";

export class WomenDiscountStrategy implements IDiscountStrategy{
    execute(item: CartItem): number {
        return item.price * .9;
    }

    shouldHandle(customer: Customer, date: Date, item: CartItem): boolean {
        return customer.gender === "female";
    }
   
}
