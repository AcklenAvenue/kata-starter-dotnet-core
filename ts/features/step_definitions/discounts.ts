import {Before, Given, Then, When} from 'cucumber'
import {expect} from 'chai';
import {Cart} from "../../cart";
import {MondayShirtDiscountStrategy} from "../../MondayShirtDiscountStrategy";
import {AllPantsDiscountStrategy} from "../../allPantsDiscountStrategy";
import {WomenDiscountStrategy} from "../../womenDiscountStrategy";
import {Customer} from "../../customer";
import {CartCalculator} from "../../cartCalculator";

Before(function() {
    this.currentDate = new Date();
    this.cart = new Cart(new CartCalculator([
        new MondayShirtDiscountStrategy(),
        new AllPantsDiscountStrategy(),
        new WomenDiscountStrategy()
    ]));
    this.customer = new Customer();
});
Given(/^the date is "([^"]*)"$/, function (dateStr) {
    this.currentDate = new Date(dateStr);
});
Given(/^the customer's shopping cart has a "([^"]*)" that costs \$([0-9]*\.?[0-9]+)$/, function (item, price) {
    this.cart.pushItem(item, parseFloat(price));
});
Given(/^the customer is a woman$/, function () {
    this.customer = new Customer("female");
});
When(/^calculating the total$/, function () {
    this.total = this.cart.calculate(this.customer, this.currentDate);
});
Then(/^the(?: discounted)? total should be \$([0-9]*\.?[0-9]+)$/, function (totalStr) {
    expect(this.total).to.equal(parseFloat(totalStr));
});
