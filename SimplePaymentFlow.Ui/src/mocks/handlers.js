// src/mocks/handlers.js
import { rest } from "msw";

export const handlers = [
  rest.get("https://localhost:7152/sites", (req, res, ctx) => {
    return res(
      ctx.status(200),
      ctx.json([
        {
          name: "Test Site 1",
          address: "5 Tall Cedar Road, Goose Island, Oregon",
          pump: {
            id: "baaff062-3f16-4e6c-9821-72199b4f82c3",
            name: "Test Pump 01",
            unlocked: false,
          },
        },
      ])
    );
  }),
];
