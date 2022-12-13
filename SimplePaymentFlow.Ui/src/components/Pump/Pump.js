import React from "react";
import { FontAwesomeIcon } from "@fortawesome/react-fontawesome";
import {
  faGasPump,
  faLock,
  faLockOpen,
} from "@fortawesome/free-solid-svg-icons";
import "./Pump.css";

function Pump(props) {
  return (
    <>
      <button
        onClick={() => props.onPumpToggleCallback(props.pump)}
        className="pumpButton"
        data-testid="toggle-button"
      >
        <span className="pumpIcon">
          <FontAwesomeIcon icon={faGasPump} />
        </span>
        <span className="pumpIcon">
          <FontAwesomeIcon icon={props.pump.unlocked ? faLockOpen : faLock} />
        </span>
      </button>
    </>
  );
}

export default Pump;
