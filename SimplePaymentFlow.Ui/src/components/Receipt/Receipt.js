import React from "react";

function Receipt(props) {
  return (
    <>
      {props.transaction && (
        <div>
          <span>
            You paid: {props.transaction?.transactionValue} at{" "}
            {props.transaction.pumpName}
          </span>
          <br />
          <span>Transaction Status: {props.transaction?.status}</span>
        </div>
      )}
    </>
  );
}

export default Receipt;
