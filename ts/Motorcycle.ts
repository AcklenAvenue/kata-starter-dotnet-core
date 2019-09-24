export class Motorcycle implements Vehicle {
    isElectric: boolean;
    normalPrice: number;
    spaces: number;

    constructor() {
        this.isElectric = false;
        this.normalPrice = 3;
        this.spaces = .5;
        this.sticker = "";
    }

    sticker: string;
}