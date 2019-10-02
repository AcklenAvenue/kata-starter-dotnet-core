import {CartItem} from "./cartItem";
import {Customer} from "./customer";
import {ICartCalculator} from "./ICartCalculator";

export class Cart {
    private readonly _items: CartItem[];
    private _cartCalculator: ICartCalculator;
    
    constructor(cartCalculator: ICartCalculator){
        this._cartCalculator = cartCalculator;
        this._items = [];
    }
    
    public pushItem(name: string, price: number): void{
        this._items.push(new CartItem(name, price));
    }
    
    public calculate(customer: Customer, date: Date) : number{
        return this._cartCalculator.calculate(customer, date, this._items);
    }
}