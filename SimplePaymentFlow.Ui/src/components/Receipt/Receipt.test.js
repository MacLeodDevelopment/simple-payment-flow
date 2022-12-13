import { render, screen } from "@testing-library/react";
import Receipt from "./Receipt";

describe("Receipt", () => {
  test("renders the receipt component as expected", () => {
    const expectedTransaction = {
      transactionValue: "£100.99",
      pumpName: "Test Pump 01",
      status: "Success",
    };

    render(<Receipt transaction={expectedTransaction}></Receipt>);

    const amountPaidElement = screen.getByText(
      "You paid: £100.99 at Test Pump 01"
    );
    expect(amountPaidElement).toBeInTheDocument();

    const statusElement = screen.getByText("Transaction Status: Success");
    expect(statusElement).toBeInTheDocument();
  });
});
