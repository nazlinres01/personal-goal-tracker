import axios from 'axios';

const API_URL = 'http://localhost:5000/api/goals'; // API URL'nizi güncelleyin

// Tüm hedefleri getir
export const getGoals = async () => {
    const response = await axios.get(API_URL);
    return response.data;
};

// ID'ye göre hedef getir
export const getGoalById = async (id) => {
    const response = await axios.get(`${API_URL}/${id}`);
    return response.data;
};

// Yeni hedef ekle
export const createGoal = async (goal) => {
    const response = await axios.post(API_URL, goal);
    return response.data;
};

// Hedef güncelle
export const updateGoal = async (id, goal) => {
    const response = await axios.put(`${API_URL}/${id}`, goal);
    return response.data;
};

// Hedef sil
export const deleteGoal = async (id) => {
    await axios.delete(`${API_URL}/${id}`);
};