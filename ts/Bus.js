"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
class Bus {
    constructor(electric = false) {
        this.isElectric = electric;
        this.normalPrice = 9;
        this.spaces = 2;
        this.sticker = "";
    }
}
exports.Bus = Bus;
