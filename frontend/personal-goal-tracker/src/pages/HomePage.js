import React from 'react';
import Header from '../components/Header';
import Footer from '../components/Footer';


function HomePage() {
  return (
    <div>
      <Header />
      <main className="home-page">
        <h2>Welcome to Personal Goal Tracker</h2>
        <p>Your one-stop solution for tracking and achieving your personal goals.</p>
        <a href="/goals" className="button">View Goals</a>
        <a href="/create-goal" className="button">Create New Goal</a>
      </main>
      <Footer />
    </div>
  );
}

export default HomePage;
