import { UsersClient } from "../generated/proto/UsersServiceClientPb";

const port = 5140;

export const client = new UsersClient(`localhost:${port}`);

export const noop = () => {};
