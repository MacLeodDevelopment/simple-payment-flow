import { render, screen } from "@testing-library/react";
import userEvent from "@testing-library/user-event";
import Search from "./Search";

describe("Search", () => {
  test("renders the label", () => {
    render(<Search />);
    const labelElement = screen.getByText("Find a Site:");
    expect(labelElement).toBeInTheDocument();
  });

  test("renders the input", () => {
    render(<Search />);

    const inputElement = screen.getByTitle("search");
    expect(inputElement).toBeInTheDocument();
  });

  test("reacts when the user enters a search term", async () => {
    var valuePassedBack = null;
    var testCallback = function (x) {
      valuePassedBack = x;
    };

    render(<Search onSearchTermChangeCallback={(x) => testCallback(x)} />);

    const inputElement = screen.getByTitle("search");
    //Simulate the user entering some text in the input.
    await userEvent.type(inputElement, "abc");
    expect(valuePassedBack).toBe("abc");
  });
});
