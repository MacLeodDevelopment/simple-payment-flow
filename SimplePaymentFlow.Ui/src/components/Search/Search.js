import React from "react";

function Search(props) {
  function invokeCallbackWithSearchTerm() {
    var searchTerm = document.getElementById("search").value;
    props.onSearchTermChangeCallback(searchTerm);
  }

  return (
    <>
      <label htmlFor="search">Find a Site:</label>

      <input
        id="search"
        title="search"
        type="text"
        placeholder="Type a Site Name or Address Here..."
        onChange={invokeCallbackWithSearchTerm}
      ></input>
    </>
  );
}

export default Search;
