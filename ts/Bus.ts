export class Bus implements Vehicle {
    isElectric: boolean;
    normalPrice: number;
    spaces: number;
    sticker: string;

    constructor(electric: boolean = false) {
        this.isElectric = electric;
        this.normalPrice = 9;
        this.spaces = 2;
        this.sticker = "";
    }
}