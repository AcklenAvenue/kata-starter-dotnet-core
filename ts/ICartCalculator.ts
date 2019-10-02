import {Customer} from "./customer";
import {CartItem} from "./cartItem";

export interface ICartCalculator {
    calculate(customer: Customer, date: Date, _items: CartItem[]): number;
}