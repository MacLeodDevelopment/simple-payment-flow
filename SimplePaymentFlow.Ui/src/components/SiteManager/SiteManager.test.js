import { render, screen, waitFor } from "@testing-library/react";
import SiteManager from "./SiteManager";

describe("Site Manager", () => {
  test("renders the sites", async () => {
    render(<SiteManager />);

    await waitFor(() => {
      const site = screen.getByText("Test Site 1");
      expect(site).toBeInTheDocument();
    });
  });
});
