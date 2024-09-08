import React from 'react';
import '../styles/Header.css';

function Header() {
  return (
    <header className="header">
      <h1>Personal Goal Tracker</h1>
      <nav>
        <ul>
          <li><a href="/">Home</a></li>
          <li><a href="/goals">Goals</a></li>
          <li><a href="/create-goal">Create Goal</a></li>
        </ul>
      </nav>
    </header>
  );
}

export default Header;
