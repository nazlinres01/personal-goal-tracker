import React from 'react';
import { BrowserRouter as Router, Route, Routes } from 'react-router-dom';
import HomePage from './pages/HomePage';
import GoalsPage from './pages/GoalsPage';
import GoalDetailPage from './pages/GoalDetailPage';
import CreateGoalPage from './pages/CreateGoalPage';
import EditGoalPage from './pages/EditGoalPage';
import './App.css';

function App() {
  return (
    <Router>
      <Routes>
        <Route path="/" element={<HomePage />} />
        <Route path="/goals" element={<GoalsPage />} />
        <Route path="/goal/:id" element={<GoalDetailPage />} />
        <Route path="/create-goal" element={<CreateGoalPage />} />
        <Route path="/edit-goal/:id" element={<EditGoalPage />} />
      </Routes>
    </Router>
  );
}

export default App;
