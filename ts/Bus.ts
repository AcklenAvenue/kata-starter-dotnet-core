export class Bus implements Vehicle {
    isElectric: boolean;
    sticker: string;

    constructor(electric: boolean = false) {
        this.isElectric = electric;
        this.sticker = "";
    }
}