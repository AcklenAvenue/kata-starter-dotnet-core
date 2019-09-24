export class Helicopter implements Vehicle {
    isElectric: boolean;
    normalPrice: number;
    spaces: number;
    sticker: string;

    constructor() {
        this.isElectric = false;
        this.normalPrice = 35;
        this.spaces = 8;
        this.sticker = "";
    }
}