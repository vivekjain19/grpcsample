import { User, UserRequest } from "../generated/proto/users_pb";
import { client } from "./utils";

export default function getUsers(id: number): User | null {
  const request = new UserRequest();
  request.setId(id);
  let user: User | null = null;

  client.getUser(request, null, function (err, response) {
    if (err) {
      console.log(err.code);
      console.log(err.message);
    } else {
      console.log(response);
      user = response;
    }
  });
  return user;
}
