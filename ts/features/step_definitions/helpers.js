"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
function catchError(fn) {
    try {
        fn();
        return false;
    }
    catch (error) {
        return error;
    }
}
exports.catchError = catchError;
