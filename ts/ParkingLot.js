"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
class ParkingLot {
    constructor(spaces) {
        this.spaces = spaces;
    }
    charge(vehicle, durationDays) {
        if (this.spaces < vehicle.spaces)
            throw new Error("rejected");
        this.spaces -= vehicle.spaces;
        let total = vehicle.normalPrice * durationDays;
        if (vehicle.isElectric) {
            total = total * .5;
        }
        if (vehicle.sticker === "trump") {
            total = total * 2;
        }
        return total;
    }
}
exports.ParkingLot = ParkingLot;
