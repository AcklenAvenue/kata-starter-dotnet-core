"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
const cucumber_1 = require("cucumber");
const chai_1 = require("chai");
const ParkingLot_1 = require("../../ParkingLot");
const Car_1 = require("../../Car");
const helpers_1 = require("./helpers");
const Motorcycle_1 = require("../../Motorcycle");
const Bus_1 = require("../../Bus");
const Helicopter_1 = require("../../Helicopter");
cucumber_1.Given(/^a parking lot with (\d+) spaces$/, function (spaces) {
    const configs = new Map();
    configs.set("Car", { spaces: 1, basePrice: 5 });
    configs.set("Motorcycle", { spaces: .5, basePrice: 3 });
    configs.set("Bus".toString(), { spaces: 2, basePrice: 9 });
    configs.set("Helicopter".toString(), { spaces: 8, basePrice: 35 });
    this.lot = new ParkingLot_1.ParkingLot(spaces, configs);
});
cucumber_1.Given(/^a normal car$/, function () {
    this.vehicle = new Car_1.Car(false);
});
cucumber_1.When(/^the vehicle stays for (\d+) days?$/, function (days) {
    this.charged = this.lot.charge(this.vehicle, days);
});
cucumber_1.Then(/^the driver is charged \$([\d.]+)$/, function (charged) {
    chai_1.expect(this.charged).to.equal(parseFloat(charged));
});
cucumber_1.Then(/^the lot is left with ([\d.]+) spaces?$/, function (spacesLeft) {
    chai_1.expect(this.lot.spaces).to.equal(parseFloat(spacesLeft));
});
cucumber_1.When(/^the vehicle attempts to enters the lot$/, function () {
    this.charged = 0;
    this.error = helpers_1.catchError(() => this.lot.charge(this.vehicle, 1));
});
cucumber_1.Then(/^the car is rejected$/, function () {
    chai_1.expect(this.error.message).to.equal("rejected");
});
cucumber_1.Given(/^an electric car$/, function () {
    this.vehicle = new Car_1.Car(true);
});
cucumber_1.Given(/^a motorcycle$/, function () {
    this.vehicle = new Motorcycle_1.Motorcycle();
});
cucumber_1.Given(/^the car has a trump sticker$/, function () {
    this.vehicle = new Car_1.Car(false, "trump");
});
cucumber_1.Given(/^a bus$/, function () {
    this.vehicle = new Bus_1.Bus(false);
});
cucumber_1.Given(/^an electric bus$/, function () {
    this.vehicle = new Bus_1.Bus(true);
});
cucumber_1.Given(/^a helicopter$/, function () {
    this.vehicle = new Helicopter_1.Helicopter();
});
