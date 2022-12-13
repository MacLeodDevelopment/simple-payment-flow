import { render, screen } from "@testing-library/react";
import SiteList from "./SiteList";

describe("Site List", () => {
  const expectedSites = [
    {
      name: "Test Site 1",
      address: "5 Tall Cedar Road, Goose Island, Oregon",
      pump: {
        id: "baaff062-3f16-4e6c-9821-72199b4f82c3",
        name: "Test Pump 01",
        unlocked: false,
      },
    },
    {
      name: "Test Site 2",
      address: "1640 Riverside Drive, Hill Valley",
      pump: {
        id: "12d3fb3d-5c02-42fc-bdf1-d1aea847f4f7",
        name: "Test Pump 02",
        unlocked: true,
      },
    },
  ];

  test("renders sites in an ordered list", () => {
    render(<SiteList sites={expectedSites} />);
    const listItems = screen.getAllByRole("listitem");
    expect(listItems[0].textContent).toContain(
      "5 Tall Cedar Road, Goose Island, Oregon"
    );
    expect(listItems[1].textContent).toContain(
      "1640 Riverside Drive, Hill Valley"
    );
  });
});
