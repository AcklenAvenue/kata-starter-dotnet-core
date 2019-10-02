import {ICartCalculator} from "./ICartCalculator";
import {IDiscountStrategy} from "./IDiscountStrategy";
import {Customer} from "./customer";
import {CartItem} from "./cartItem";

export class CartCalculator implements ICartCalculator {
    private _strategies: IDiscountStrategy[];

    constructor(strategies: IDiscountStrategy[]) {
        this._strategies = strategies;
    }

    calculate(customer: Customer, date: Date, items: CartItem[]): number {
        return items
            .map(i => this.getDiscountedPrice(i, customer, date))
            .reduce((p, c) => c + p);
    }

    private getDiscountedPrice(item: CartItem, customer: Customer, date: Date): number {
        const priceOptions = this._strategies
            .filter(s => s.shouldHandle(customer, date, item))
            .map(s => s.execute(item));

        if (priceOptions.length === 0) return item.price;

        return Math.max(...priceOptions);
    }
}