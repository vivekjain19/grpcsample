import getUser from "./get-user";

function run() {
  const user = getUser(1);
  console.log(user?.toString());
}

run();
