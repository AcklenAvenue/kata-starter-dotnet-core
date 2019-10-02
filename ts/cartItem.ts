export class CartItem {
    price: any;
    name: string;
    
    constructor(name: string, price: number) {
        this.name = name;
        this.price = price;
    }
}