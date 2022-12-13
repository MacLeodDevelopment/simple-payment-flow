import React from "react";
import Pay from "../Pay/Pay";
import Pump from "../Pump/Pump";
import SiteAddress from "../SiteAddress/SiteAddress";
import SiteName from "../SiteName/SiteName";
import "./SiteList.css";

function SiteList(props) {
  return (
    <>
      <ol>
        {props.sites?.map((site) => (
          <li key={site.name}>
            <SiteName name={site.name} />
            <SiteAddress address={site.address} />
            <Pump
              pump={site.pump}
              onPumpToggleCallback={(pump) => props.onPumpToggleCallback(pump)}
            />
            <Pay
              disabled={!site.pump.unlocked}
              pumpId={site.pump.id}
              onPayCallback={(amount, pumpId) =>
                props.onPayCallback(amount, pumpId)
              }
            />
          </li>
        ))}
      </ol>
    </>
  );
}

export default SiteList;
