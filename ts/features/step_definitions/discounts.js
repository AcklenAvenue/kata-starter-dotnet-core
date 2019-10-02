"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
const cucumber_1 = require("cucumber");
const chai_1 = require("chai");
const cart_1 = require("../../cart");
const MondayShirtDiscountStrategy_1 = require("../../MondayShirtDiscountStrategy");
const allPantsDiscountStrategy_1 = require("../../allPantsDiscountStrategy");
const womenDiscountStrategy_1 = require("../../womenDiscountStrategy");
const customer_1 = require("../../customer");
const cartCalculator_1 = require("../../cartCalculator");
cucumber_1.Before(function () {
    this.currentDate = new Date();
    this.cart = new cart_1.Cart(new cartCalculator_1.CartCalculator([
        new MondayShirtDiscountStrategy_1.MondayShirtDiscountStrategy(),
        new allPantsDiscountStrategy_1.AllPantsDiscountStrategy(),
        new womenDiscountStrategy_1.WomenDiscountStrategy()
    ]));
    this.customer = new customer_1.Customer();
});
cucumber_1.Given(/^the date is "([^"]*)"$/, function (dateStr) {
    this.currentDate = new Date(dateStr);
});
cucumber_1.Given(/^the customer's shopping cart has a "([^"]*)" that costs \$([0-9]*\.?[0-9]+)$/, function (item, price) {
    this.cart.pushItem(item, parseFloat(price));
});
cucumber_1.Given(/^the customer is a woman$/, function () {
    this.customer = new customer_1.Customer("female");
});
cucumber_1.When(/^calculating the total$/, function () {
    this.total = this.cart.calculate(this.customer, this.currentDate);
});
cucumber_1.Then(/^the(?: discounted)? total should be \$([0-9]*\.?[0-9]+)$/, function (totalStr) {
    chai_1.expect(this.total).to.equal(parseFloat(totalStr));
});
