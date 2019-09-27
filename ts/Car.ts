export class Car implements Vehicle {

    constructor(electric: boolean = false, sticker: string = "") {
        this.isElectric = electric;
        this.sticker = sticker;
    }

    isElectric: boolean;
    sticker: string;
}