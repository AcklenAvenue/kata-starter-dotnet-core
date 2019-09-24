"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
class Car {
    constructor(electric = false, sticker = "") {
        this.spaces = 1;
        this.normalPrice = 5;
        this.isElectric = electric;
        this.sticker = sticker;
    }
}
exports.Car = Car;
