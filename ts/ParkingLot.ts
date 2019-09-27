import {Bus} from "./Bus";
import {IVehicleConfig} from "./IVehicleConfig";

interface IPriceModificationStrategy {
    execute(vehicle: Vehicle, config: IVehicleConfig): number;
}

export class ParkingLot {
    private _configs: Map<string, IVehicleConfig>;
    private _strategies: Array<IPriceModificationStrategy>;
    
    constructor(public spacesAvailable: number, configs: Map<string, IVehicleConfig>, strategies: Array<IPriceModificationStrategy>) {
        this._configs = configs;
        this._strategies = strategies;
    }

    charge(vehicle: Vehicle, durationDays: number) {

        // const calculator = priceCalculatorFactory.create(vehicle, durationDays);
        // return calculator.calculate();
        
        const config = this._configs.get(vehicle.constructor.name) || { spaces: 0, basePrice: 0 };
        
        if (this.spacesAvailable < config.spaces) throw new Error("rejected");

        let total = this._strategies.reduce((prev, curr, index) => {
            return prev + curr.execute(vehicle, config);
        }, 0);
        this.spacesAvailable -= config.spaces;
        return total;
        
        // total = config.basePrice * durationDays;
        //
        // if(durationDays >= 6){
        //     total = total * .7;
        // }
        // else if(durationDays >= 3){
        //     total = total * .8;
        // }
        //
        // if (vehicle.isElectric) {
        //     total = total * .5;
        // }
        //
        // if(vehicle.sticker === "trump")
        // {
        //     total = total * 2;
        // }
        //
        // if(vehicle instanceof Bus && vehicle.isElectric && durationDays >= 10){
        //     total = 20;
        // }
        //
        return total;
    }
}