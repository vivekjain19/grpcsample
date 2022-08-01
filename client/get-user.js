"use strict";
exports.__esModule = true;
var users_pb_1 = require("../generated/proto/users_pb");
var utils_1 = require("./utils");
function getUsers(id) {
    var request = new users_pb_1.UserRequest();
    request.setId(id);
    var user = null;
    utils_1.client.getUser(request, null, function (err, response) {
        if (err) {
            console.log(err.code);
            console.log(err.message);
        }
        else {
            console.log(response);
            user = response;
        }
    });
    return user;
}
exports["default"] = getUsers;
