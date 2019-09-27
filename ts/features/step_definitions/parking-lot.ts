import {Before, Given, Then, When} from 'cucumber'
import {expect} from 'chai';
import {ParkingLot} from "../../ParkingLot";
import {Car} from "../../Car";
import {catchError} from "./helpers";
import {Motorcycle} from "../../Motorcycle";
import {Bus} from "../../Bus";
import {Helicopter} from "../../Helicopter";
import {IVehicleConfig} from "../../IVehicleConfig";

Given(/^a parking lot with (\d+) spaces$/, function (spaces: number) {
    const configs = new Map<string, IVehicleConfig>();
    configs.set("Car", { spaces: 1, basePrice: 5 });
    configs.set("Motorcycle", { spaces: .5, basePrice: 3 });
    configs.set("Bus".toString(), { spaces: 2, basePrice: 9 });
    configs.set("Helicopter".toString(), { spaces: 8, basePrice: 35 });
    this.lot = new ParkingLot(spaces, configs, [new LongTermParkingStrategy(), new ElectricVehicleStrategy()]);
});
Given(/^a normal car$/, function () {
    this.vehicle = new Car(false);
});
When(/^the vehicle stays for (\d+) days?$/, function (days: number) {
    this.charged = this.lot.charge(this.vehicle, days);
});
Then(/^the driver is charged \$([\d.]+)$/, function (charged: string) {
    expect(this.charged).to.equal(parseFloat(charged));
});
Then(/^the lot is left with ([\d.]+) spaces?$/, function (spacesLeft: string) {
    expect(this.lot.spaces).to.equal(parseFloat(spacesLeft));
});
When(/^the vehicle attempts to enters the lot$/, function () {
    this.charged = 0;
    this.error = catchError(() => this.lot.charge(this.vehicle, 1));
});
Then(/^the car is rejected$/, function () {
    expect(this.error.message).to.equal("rejected");
});
Given(/^an electric car$/, function () {
    this.vehicle = new Car(true);
});
Given(/^a motorcycle$/, function () {
    this.vehicle = new Motorcycle();
});
Given(/^the car has a trump sticker$/, function () {
    this.vehicle = new Car(false, "trump");
});
Given(/^a bus$/, function () {
    this.vehicle = new Bus(false);
});
Given(/^an electric bus$/, function () {
    this.vehicle = new Bus(true);
});
Given(/^a helicopter$/, function () {
    this.vehicle = new Helicopter();
});
