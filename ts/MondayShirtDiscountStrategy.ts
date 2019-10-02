import {IDiscountStrategy} from "./IDiscountStrategy";
import {Customer} from "./customer";
import {CartItem} from "./cartItem";

export class MondayShirtDiscountStrategy implements IDiscountStrategy {
    execute(item: CartItem): number {
        return item.price * .8;
    }

    shouldHandle(customer: Customer, date: Date, item: CartItem): boolean {
        if(item.name!=="shirt") return false;
        
        const isMonday = date.getDay() === 1;
        return isMonday;
    }
    
}