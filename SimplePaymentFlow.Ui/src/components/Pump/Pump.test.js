import { fireEvent, render, screen } from "@testing-library/react";
import Pump from "./Pump";

describe("Pump", () => {
  test("reacts as expected when the user clicks the button", async () => {
    var pumpPassedBack = null;
    var testCallback = function (x) {
      pumpPassedBack = x;
    };

    const expectedPump = {
      id: "Expected ID",
    };

    render(
      <Pump pump={expectedPump} onPumpToggleCallback={(x) => testCallback(x)} />
    );

    const buttonElement = screen.getByTestId("toggle-button");
    expect(buttonElement).toBeInTheDocument();

    fireEvent.click(buttonElement);

    expect(pumpPassedBack).toBe(expectedPump);
  });
});
