export class ParkingLot {
    constructor(public spaces: number) {

    }

    charge(vehicle: Vehicle, durationDays: number) {
        if (this.spaces < vehicle.spaces) throw new Error("rejected");

        this.spaces -= vehicle.spaces;
        let total = vehicle.normalPrice * durationDays;

        if (vehicle.isElectric) {
            total = total * .5;
        }
        
        if(vehicle.sticker === "trump")
        {
            total = total * 2;
        }
        
        return total;
    }
}