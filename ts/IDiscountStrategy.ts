import {CartItem} from "./cartItem";

export interface IDiscountStrategy {
    execute(item: CartItem): number;
}

