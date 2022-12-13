import { render, screen } from "@testing-library/react";
import SiteAddress from "./SiteAddress";

describe("Site Address", () => {
  test("renders the site address", () => {
    const expectedAddress = "221b Baker Street";

    render(<SiteAddress address={expectedAddress} />);

    const addressElement = screen.getByText((content) =>
      content.endsWith(expectedAddress)
    );
    expect(addressElement).toBeInTheDocument();
  });
});
