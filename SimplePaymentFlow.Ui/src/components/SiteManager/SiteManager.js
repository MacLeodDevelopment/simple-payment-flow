import React from "react";
import { useState, useEffect } from "react";
import Receipt from "../Receipt/Receipt";
import SiteList from "../SiteList/SiteList";
import Search from "../Search/Search";
import "./SiteManager.css";

function SiteManager() {
  const [loading, setLoading] = useState(false);
  const [error, setError] = useState(null);
  const [sites, setSites] = useState([]);
  const [filteredSites, setFilteredSites] = useState([]);
  const [toggledPump, setToggledPump] = useState(null);
  const [transaction, setTransaction] = useState(null);

  useEffect(() => {
    async function getSites() {
      var url = "https://localhost:7152/sites";

      await fetch(url)
        .then((res) => res.json())
        .then(
          (response) => {
            setSites(response);
            setFilteredSites(response);
            setLoading(false);
          },
          (error) => {
            setLoading(false);
            setError(error);
          }
        );
    }

    setLoading(true);
    getSites();
  }, [toggledPump]);

  function onSearchTermChangeCallback(searchTerm) {
    setFilteredSites(
      sites.filter(
        (site) =>
          site.name.toLowerCase().includes(searchTerm.toLowerCase()) ||
          site.address.toLowerCase().includes(searchTerm.toLowerCase())
      )
    );
  }

  function onPumpToggleCallback(pump) {
    async function putPump() {
      var url =
        "https://localhost:7152/pump/" +
        pump.id +
        "?unlocked=" +
        !pump.unlocked;

      await fetch(url, {
        method: "PUT",
        headers: {
          "Content-Type": "application/json",
        },
        body: null,
      }).then(
        () => {
          setToggledPump(pump);
          setLoading(false);
        },
        (error) => {
          setLoading(false);
          setError(error);
        }
      );
    }

    setLoading(true);
    putPump();
  }

  function onPayCallback(amount, pumpId) {
    async function postPayment() {
      var url = "https://localhost:7152/transactions/";

      await fetch(url, {
        method: "POST",
        headers: {
          "Content-Type": "application/json",
        },
        body: JSON.stringify({
          transactionValue: amount,
          pumpId: pumpId,
        }),
      })
        .then((response) => response.json())
        .then(
          (transaction) => {
            setTransaction(transaction);
            setLoading(false);
          },
          (error) => {
            setLoading(false);
            setError(error);
          }
        );
    }

    setLoading(true);
    postPayment();
  }

  return (
    <>
      <h1>Simple Payment Flow</h1>
      <aside className="aside aside-1">
        <Search
          onSearchTermChangeCallback={(term) =>
            onSearchTermChangeCallback(term)
          }
        ></Search>
      </aside>

      <aside className="aside aside-1">
        <Receipt transaction={transaction}></Receipt>
      </aside>

      <article className="main">
        {loading && !error && <span>Loading...</span>}
        {!loading && !error && (
          <>
            <SiteList
              sites={filteredSites}
              onPumpToggleCallback={(pump) => onPumpToggleCallback(pump)}
              onPayCallback={(amount, pumpId) => onPayCallback(amount, pumpId)}
            />
          </>
        )}
        {error && <span>Something went wrong!</span>}
      </article>
    </>
  );
}

export default SiteManager;
