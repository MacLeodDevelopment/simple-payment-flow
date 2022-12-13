import React from "react";
import { FontAwesomeIcon } from "@fortawesome/react-fontawesome";
import { faCreditCard } from "@fortawesome/free-solid-svg-icons";
import "./Pay.css";

function Pay(props) {
  return (
    <>
      <button
        disabled={props.disabled}
        onClick={() => props.onPayCallback(10.0, props.pumpId)}
        className="payButton"
      >
        <span className="payIcon">
          <FontAwesomeIcon icon={faCreditCard} />
        </span>
        Pay £10
      </button>
    </>
  );
}

export default Pay;
