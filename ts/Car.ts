export class Car implements Vehicle {

    constructor(electric: boolean = false, sticker: string = "") {
        this.spaces = 1;
        this.normalPrice = 5;
        this.isElectric = electric;
        this.sticker = sticker;
    }

    spaces: number;
    normalPrice: number;
    isElectric: boolean;
    sticker: string;
}