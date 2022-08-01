"use strict";
exports.__esModule = true;
var get_user_1 = require("./get-user");
function run() {
    var user = (0, get_user_1["default"])(1);
    console.log(user === null || user === void 0 ? void 0 : user.toString());
}
run();
