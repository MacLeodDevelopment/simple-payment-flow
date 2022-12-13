import { render, screen } from "@testing-library/react";
import SiteName from "./SiteName";

describe("Site Name", () => {
  test("renders the site name", () => {
    const expectedSiteName = "Expected Site Name";
    render(<SiteName name={expectedSiteName} />);

    const titleElement = screen.getByText(expectedSiteName);
    expect(titleElement).toBeInTheDocument();
  });
});
