import { fireEvent, render, screen } from "@testing-library/react";
import Pay from "./Pay";

describe("Pay", () => {
  test("disables the pay button as expected", () => {
    render(
      <Pay
        disabled={true}
        pumpId={"anything"}
        onPayCallback={(amount, pumpId) => props.onPayCallback(amount, pumpId)}
      />
    );

    const buttonElement = screen.getByText("Pay £10");
    expect(buttonElement).toBeInTheDocument();
    expect(buttonElement).toBeDisabled();
  });

  test("reacts as expected when the user clicks the button", async () => {
    var amountPassedBack = null;
    var pumpIdPassedBack = null;
    var testCallback = function (x, y) {
      amountPassedBack = x;
      pumpIdPassedBack = y;
    };

    render(
      <Pay
        disabled={false}
        pumpId={"Expected Pump ID"}
        onPayCallback={(x, y) => testCallback(x, y)}
      />
    );

    const buttonElement = screen.getByText("Pay £10");
    expect(buttonElement).toBeInTheDocument();

    fireEvent.click(buttonElement);

    expect(amountPassedBack).toBe(10);
    expect(pumpIdPassedBack).toBe("Expected Pump ID");
  });
});
