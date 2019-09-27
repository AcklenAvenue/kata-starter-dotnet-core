export class Motorcycle implements Vehicle {
    isElectric: boolean;
    
    constructor() {
        this.isElectric = false;
        this.sticker = "";
    }

    sticker: string;
}