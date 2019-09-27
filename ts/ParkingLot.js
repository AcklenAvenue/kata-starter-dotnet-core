"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
const Bus_1 = require("./Bus");
class ParkingLot {
    constructor(spaces, configs) {
        this.spaces = spaces;
        this.configs = configs;
    }
    charge(vehicle, durationDays) {
        // const calculator = priceCalculatorFactory.create(vehicle, durationDays);
        // return calculator.calculate();
        const config = this.configs.get(vehicle.constructor.name) || { spaces: 0, basePrice: 0 };
        if (this.spaces < config.spaces)
            throw new Error("rejected");
        this.spaces -= config.spaces;
        let total = config.basePrice * durationDays;
        if (durationDays >= 6) {
            total = total * .7;
        }
        else if (durationDays >= 3) {
            total = total * .8;
        }
        if (vehicle.isElectric) {
            total = total * .5;
        }
        if (vehicle.sticker === "trump") {
            total = total * 2;
        }
        if (vehicle instanceof Bus_1.Bus && vehicle.isElectric && durationDays >= 10) {
            total = 20;
        }
        return total;
    }
}
exports.ParkingLot = ParkingLot;
