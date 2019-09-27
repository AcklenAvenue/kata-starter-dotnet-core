export class Helicopter implements Vehicle {
    isElectric: boolean;
    sticker: string;

    constructor() {
        this.isElectric = false;
        this.sticker = "";
    }
}