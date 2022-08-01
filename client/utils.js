"use strict";
exports.__esModule = true;
exports.noop = exports.client = void 0;
var UsersServiceClientPb_1 = require("../generated/proto/UsersServiceClientPb");
var port = 5140;
exports.client = new UsersServiceClientPb_1.UsersClient("localhost:".concat(port));
var noop = function () { };
exports.noop = noop;
